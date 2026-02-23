using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhaebo;

/// <summary>
/// Abstract class for Rhaebo (genus).
/// NCBI TaxId: 651679
/// </summary>
public abstract class Rhaebo : Bufonidae, IRhaebo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhaebo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651679;

    /// <inheritdoc />
    public virtual string GenusName => "Rhaebo";

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
