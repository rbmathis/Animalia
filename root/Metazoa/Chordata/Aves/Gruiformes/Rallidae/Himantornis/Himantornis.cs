using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Himantornis;

/// <summary>
/// Abstract class for Himantornis (genus).
/// NCBI TaxId: 458193
/// </summary>
public abstract class Himantornis : Rallidae, IHimantornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Himantornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458193;

    /// <inheritdoc />
    public virtual string GenusName => "Himantornis";

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
