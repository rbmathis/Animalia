using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Calyptura;

/// <summary>
/// Abstract class for Calyptura (genus).
/// NCBI TaxId: 1178542
/// </summary>
public abstract class Calyptura : Passeriformes_incertae_sedis, ICalyptura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1178542;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptura";

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
