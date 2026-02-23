using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Cristidorsa;

/// <summary>
/// Abstract class for Cristidorsa (genus).
/// NCBI TaxId: 2547943
/// </summary>
public abstract class Cristidorsa : Agamidae, ICristidorsa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cristidorsa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547943;

    /// <inheritdoc />
    public virtual string GenusName => "Cristidorsa";

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
