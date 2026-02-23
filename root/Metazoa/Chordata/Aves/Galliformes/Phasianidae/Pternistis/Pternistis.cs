using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pternistis;

/// <summary>
/// Abstract class for Pternistis (genus).
/// NCBI TaxId: 1756210
/// </summary>
public abstract class Pternistis : Phasianidae, IPternistis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pternistis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1756210;

    /// <inheritdoc />
    public virtual string GenusName => "Pternistis";

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
