using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Myzornis;

/// <summary>
/// Abstract class for Myzornis (genus).
/// NCBI TaxId: 634317
/// </summary>
public abstract class Myzornis : Passeriformes_incertae_sedis, IMyzornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myzornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634317;

    /// <inheritdoc />
    public virtual string GenusName => "Myzornis";

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
