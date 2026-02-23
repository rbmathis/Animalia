using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Pericrocotus;

/// <summary>
/// Abstract class for Pericrocotus (genus).
/// NCBI TaxId: 254641
/// </summary>
public abstract class Pericrocotus : Campephagidae, IPericrocotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pericrocotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254641;

    /// <inheritdoc />
    public virtual string GenusName => "Pericrocotus";

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
