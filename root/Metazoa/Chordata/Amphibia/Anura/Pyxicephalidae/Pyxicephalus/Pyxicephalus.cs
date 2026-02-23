using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Pyxicephalus;

/// <summary>
/// Abstract class for Pyxicephalus (genus).
/// NCBI TaxId: 30356
/// </summary>
public abstract class Pyxicephalus : Pyxicephalidae, IPyxicephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyxicephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30356;

    /// <inheritdoc />
    public virtual string GenusName => "Pyxicephalus";

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
