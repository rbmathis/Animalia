using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufoides;

/// <summary>
/// Abstract class for Bufoides (genus).
/// NCBI TaxId: 1785713
/// </summary>
public abstract class Bufoides : Bufonidae, IBufoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bufoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1785713;

    /// <inheritdoc />
    public virtual string GenusName => "Bufoides";

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
