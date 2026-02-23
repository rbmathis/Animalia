using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Stemonosudis;

/// <summary>
/// Abstract class for Stemonosudis (genus).
/// NCBI TaxId: 319771
/// </summary>
public abstract class Stemonosudis : Paralepididae, IStemonosudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stemonosudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319771;

    /// <inheritdoc />
    public virtual string GenusName => "Stemonosudis";

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
