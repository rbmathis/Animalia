using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Abstract class for Passer (genus).
/// NCBI TaxId: 9159
/// </summary>
public abstract class Passer : Passeridae, IPasser
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Passer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9159;

    /// <inheritdoc />
    public virtual string GenusName => "Passer";

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
