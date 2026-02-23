using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ciccaba;

/// <summary>
/// Abstract class for Ciccaba (genus).
/// NCBI TaxId: 111828
/// </summary>
public abstract class Ciccaba : Strigidae, ICiccaba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ciccaba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111828;

    /// <inheritdoc />
    public virtual string GenusName => "Ciccaba";

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
