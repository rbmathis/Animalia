using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Ranodon;

/// <summary>
/// Abstract class for Ranodon (genus).
/// NCBI TaxId: 113096
/// </summary>
public abstract class Ranodon : Hynobiidae, IRanodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ranodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113096;

    /// <inheritdoc />
    public virtual string GenusName => "Ranodon";

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
