using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Ompok;

/// <summary>
/// Abstract class for Ompok (genus).
/// NCBI TaxId: 209165
/// </summary>
public abstract class Ompok : Siluridae, IOmpok
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ompok";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209165;

    /// <inheritdoc />
    public virtual string GenusName => "Ompok";

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
