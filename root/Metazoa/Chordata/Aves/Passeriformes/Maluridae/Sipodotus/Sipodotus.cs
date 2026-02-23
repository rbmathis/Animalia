using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Sipodotus;

/// <summary>
/// Abstract class for Sipodotus (genus).
/// NCBI TaxId: 1034747
/// </summary>
public abstract class Sipodotus : Maluridae, ISipodotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sipodotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1034747;

    /// <inheritdoc />
    public virtual string GenusName => "Sipodotus";

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
