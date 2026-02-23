using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Andersonia;

/// <summary>
/// Abstract class for Andersonia (genus).
/// NCBI TaxId: 210575
/// </summary>
public abstract class Andersonia : Amphiliidae, IAndersonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andersonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210575;

    /// <inheritdoc />
    public virtual string GenusName => "Andersonia";

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
