using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Guarocuyus;

/// <summary>
/// Abstract class for Guarocuyus (genus).
/// NCBI TaxId: 3069443
/// </summary>
public abstract class Guarocuyus : Diploglossidae, IGuarocuyus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guarocuyus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3069443;

    /// <inheritdoc />
    public virtual string GenusName => "Guarocuyus";

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
