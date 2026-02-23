using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Poblana;

/// <summary>
/// Abstract class for Poblana (genus).
/// NCBI TaxId: 461518
/// </summary>
public abstract class Poblana : Atherinopsidae, IPoblana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poblana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461518;

    /// <inheritdoc />
    public virtual string GenusName => "Poblana";

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
