using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Dinolestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Dinolestidae.Dinolestes;

/// <summary>
/// Abstract class for Dinolestes (genus).
/// NCBI TaxId: 390326
/// </summary>
public abstract class Dinolestes : Dinolestidae, IDinolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390326;

    /// <inheritdoc />
    public virtual string GenusName => "Dinolestes";

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
