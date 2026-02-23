using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Aptocyclus;

/// <summary>
/// Abstract class for Aptocyclus (genus).
/// NCBI TaxId: 181458
/// </summary>
public abstract class Aptocyclus : Cyclopteridae, IAptocyclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aptocyclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181458;

    /// <inheritdoc />
    public virtual string GenusName => "Aptocyclus";

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
