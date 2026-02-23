using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolenidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Centrolenidae_incertae_sedis.Ikakogi;

/// <summary>
/// Abstract class for Ikakogi (genus).
/// NCBI TaxId: 715367
/// </summary>
public abstract class Ikakogi : Centrolenidae_incertae_sedis, IIkakogi
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ikakogi";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 715367;

    /// <inheritdoc />
    public virtual string GenusName => "Ikakogi";

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
