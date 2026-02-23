using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Corallus;

/// <summary>
/// Abstract class for Corallus (genus).
/// NCBI TaxId: 51859
/// </summary>
public abstract class Corallus : Boidae, ICorallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51859;

    /// <inheritdoc />
    public virtual string GenusName => "Corallus";

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
