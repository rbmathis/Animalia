using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Chamaea;

/// <summary>
/// Abstract class for Chamaea (genus).
/// NCBI TaxId: 190679
/// </summary>
public abstract class Chamaea : Sylviidae_incertae_sedis, IChamaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190679;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaea";

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
