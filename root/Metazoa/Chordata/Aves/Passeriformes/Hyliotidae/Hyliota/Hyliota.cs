using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hyliotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hyliotidae.Hyliota;

/// <summary>
/// Abstract class for Hyliota (genus).
/// NCBI TaxId: 343931
/// </summary>
public abstract class Hyliota : Hyliotidae, IHyliota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyliota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 343931;

    /// <inheritdoc />
    public virtual string GenusName => "Hyliota";

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
