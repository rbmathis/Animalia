using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Snowornis;

/// <summary>
/// Abstract class for Snowornis (genus).
/// NCBI TaxId: 381435
/// </summary>
public abstract class Snowornis : Cotingidae, ISnowornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Snowornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381435;

    /// <inheritdoc />
    public virtual string GenusName => "Snowornis";

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
