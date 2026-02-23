using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Liua;

/// <summary>
/// Abstract class for Liua (genus).
/// NCBI TaxId: 156991
/// </summary>
public abstract class Liua : Hynobiidae, ILiua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156991;

    /// <inheritdoc />
    public virtual string GenusName => "Liua";

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
