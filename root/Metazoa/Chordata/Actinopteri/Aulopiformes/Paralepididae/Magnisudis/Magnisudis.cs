using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Magnisudis;

/// <summary>
/// Abstract class for Magnisudis (genus).
/// NCBI TaxId: 319768
/// </summary>
public abstract class Magnisudis : Paralepididae, IMagnisudis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Magnisudis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319768;

    /// <inheritdoc />
    public virtual string GenusName => "Magnisudis";

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
