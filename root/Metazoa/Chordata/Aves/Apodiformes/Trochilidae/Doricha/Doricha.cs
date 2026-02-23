using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Doricha;

/// <summary>
/// Abstract class for Doricha (genus).
/// NCBI TaxId: 1315739
/// </summary>
public abstract class Doricha : Trochilidae, IDoricha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doricha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315739;

    /// <inheritdoc />
    public virtual string GenusName => "Doricha";

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
