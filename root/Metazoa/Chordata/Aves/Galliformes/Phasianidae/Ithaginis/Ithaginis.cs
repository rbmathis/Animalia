using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ithaginis;

/// <summary>
/// Abstract class for Ithaginis (genus).
/// NCBI TaxId: 83284
/// </summary>
public abstract class Ithaginis : Phasianidae, IIthaginis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ithaginis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83284;

    /// <inheritdoc />
    public virtual string GenusName => "Ithaginis";

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
