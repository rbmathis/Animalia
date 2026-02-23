using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Neolestes;

/// <summary>
/// Abstract class for Neolestes (genus).
/// NCBI TaxId: 749577
/// </summary>
public abstract class Neolestes : Passeriformes_incertae_sedis, INeolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 749577;

    /// <inheritdoc />
    public virtual string GenusName => "Neolestes";

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
