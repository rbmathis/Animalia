using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aptornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aptornithidae.Aptornis;

/// <summary>
/// Abstract class for Aptornis (genus).
/// NCBI TaxId: 54365
/// </summary>
public abstract class Aptornis : Aptornithidae, IAptornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aptornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54365;

    /// <inheritdoc />
    public virtual string GenusName => "Aptornis";

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
