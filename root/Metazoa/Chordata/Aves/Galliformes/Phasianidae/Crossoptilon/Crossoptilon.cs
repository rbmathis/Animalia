using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Crossoptilon;

/// <summary>
/// Abstract class for Crossoptilon (genus).
/// NCBI TaxId: 9095
/// </summary>
public abstract class Crossoptilon : Phasianidae, ICrossoptilon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossoptilon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9095;

    /// <inheritdoc />
    public virtual string GenusName => "Crossoptilon";

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
