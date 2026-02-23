using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Nesofregetta;

/// <summary>
/// Abstract class for Nesofregetta (genus).
/// NCBI TaxId: 1118811
/// </summary>
public abstract class Nesofregetta : Procellariiformes, INesofregetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesofregetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118811;

    /// <inheritdoc />
    public virtual string GenusName => "Nesofregetta";

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
