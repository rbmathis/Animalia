using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Cephalopyrus;

/// <summary>
/// Abstract class for Cephalopyrus (genus).
/// NCBI TaxId: 1226578
/// </summary>
public abstract class Cephalopyrus : Paridae, ICephalopyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalopyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226578;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalopyrus";

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
