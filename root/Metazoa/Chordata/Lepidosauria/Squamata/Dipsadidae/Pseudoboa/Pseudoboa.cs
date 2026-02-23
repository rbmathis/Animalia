using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Pseudoboa;

/// <summary>
/// Abstract class for Pseudoboa (genus).
/// NCBI TaxId: 121358
/// </summary>
public abstract class Pseudoboa : Dipsadidae, IPseudoboa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoboa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121358;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoboa";

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
