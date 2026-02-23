using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Glyptoparus;

/// <summary>
/// Abstract class for Glyptoparus (genus).
/// NCBI TaxId: 1156468
/// </summary>
public abstract class Glyptoparus : Blenniidae, IGlyptoparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptoparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156468;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptoparus";

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
