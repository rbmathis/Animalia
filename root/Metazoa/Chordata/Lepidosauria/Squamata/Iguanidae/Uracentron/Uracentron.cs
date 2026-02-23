using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Uracentron;

/// <summary>
/// Abstract class for Uracentron (genus).
/// NCBI TaxId: 179260
/// </summary>
public abstract class Uracentron : Iguanidae, IUracentron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uracentron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179260;

    /// <inheritdoc />
    public virtual string GenusName => "Uracentron";

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
