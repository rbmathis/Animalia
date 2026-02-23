using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Notolepis;

/// <summary>
/// Abstract class for Notolepis (genus).
/// NCBI TaxId: 948062
/// </summary>
public abstract class Notolepis : Paralepididae, INotolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948062;

    /// <inheritdoc />
    public virtual string GenusName => "Notolepis";

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
