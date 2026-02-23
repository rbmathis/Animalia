using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Indotyphlus;

/// <summary>
/// Abstract class for Indotyphlus (genus).
/// NCBI TaxId: 264015
/// </summary>
public abstract class Indotyphlus : Indotyphlidae, IIndotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264015;

    /// <inheritdoc />
    public virtual string GenusName => "Indotyphlus";

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
