using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Rhabdoblennius;

/// <summary>
/// Abstract class for Rhabdoblennius (genus).
/// NCBI TaxId: 57850
/// </summary>
public abstract class Rhabdoblennius : Blenniidae, IRhabdoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57850;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdoblennius";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
