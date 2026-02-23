using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae.Scolecomorphus;

/// <summary>
/// Abstract class for Scolecomorphus (genus).
/// NCBI TaxId: 260999
/// </summary>
public abstract class Scolecomorphus : Scolecomorphidae, IScolecomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolecomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260999;

    /// <inheritdoc />
    public virtual string GenusName => "Scolecomorphus";

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
