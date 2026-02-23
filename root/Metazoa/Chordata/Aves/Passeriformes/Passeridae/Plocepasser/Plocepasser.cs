using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Plocepasser;

/// <summary>
/// Abstract class for Plocepasser (genus).
/// NCBI TaxId: 99180
/// </summary>
public abstract class Plocepasser : Passeridae, IPlocepasser
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plocepasser";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 99180;

    /// <inheritdoc />
    public virtual string GenusName => "Plocepasser";

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
