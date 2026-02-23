using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Trichobatrachus;

/// <summary>
/// Abstract class for Trichobatrachus (genus).
/// NCBI TaxId: 111095
/// </summary>
public abstract class Trichobatrachus : Arthroleptidae, ITrichobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111095;

    /// <inheritdoc />
    public virtual string GenusName => "Trichobatrachus";

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
