using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Panurus;

/// <summary>
/// Abstract class for Panurus (genus).
/// NCBI TaxId: 181100
/// </summary>
public abstract class Panurus : Sylviidae_incertae_sedis, IPanurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Panurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181100;

    /// <inheritdoc />
    public virtual string GenusName => "Panurus";

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
