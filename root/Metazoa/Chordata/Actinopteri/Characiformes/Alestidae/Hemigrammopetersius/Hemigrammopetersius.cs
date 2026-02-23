using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Hemigrammopetersius;

/// <summary>
/// Abstract class for Hemigrammopetersius (genus).
/// NCBI TaxId: 304007
/// </summary>
public abstract class Hemigrammopetersius : Alestidae, IHemigrammopetersius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigrammopetersius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304007;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigrammopetersius";

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
