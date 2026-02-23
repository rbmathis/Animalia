using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Heterotis;

/// <summary>
/// Abstract class for Heterotis (genus).
/// NCBI TaxId: 91720
/// </summary>
public abstract class Heterotis : Osteoglossidae, IHeterotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91720;

    /// <inheritdoc />
    public virtual string GenusName => "Heterotis";

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
