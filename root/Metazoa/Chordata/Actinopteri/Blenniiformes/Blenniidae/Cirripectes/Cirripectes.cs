using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirripectes;

/// <summary>
/// Abstract class for Cirripectes (genus).
/// NCBI TaxId: 703910
/// </summary>
public abstract class Cirripectes : Blenniidae, ICirripectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirripectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703910;

    /// <inheritdoc />
    public virtual string GenusName => "Cirripectes";

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
