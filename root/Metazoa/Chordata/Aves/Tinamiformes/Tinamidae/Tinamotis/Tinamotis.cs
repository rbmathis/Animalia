using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Tinamotis;

/// <summary>
/// Abstract class for Tinamotis (genus).
/// NCBI TaxId: 555359
/// </summary>
public abstract class Tinamotis : Tinamidae, ITinamotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tinamotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555359;

    /// <inheritdoc />
    public virtual string GenusName => "Tinamotis";

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
