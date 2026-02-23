using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Rhizoprionodon;

/// <summary>
/// Abstract class for Rhizoprionodon (genus).
/// NCBI TaxId: 34769
/// </summary>
public abstract class Rhizoprionodon : Carcharhinidae, IRhizoprionodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhizoprionodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34769;

    /// <inheritdoc />
    public virtual string GenusName => "Rhizoprionodon";

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
