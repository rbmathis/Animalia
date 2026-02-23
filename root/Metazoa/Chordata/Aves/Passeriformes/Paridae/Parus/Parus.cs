using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Parus;

/// <summary>
/// Abstract class for Parus (genus).
/// NCBI TaxId: 9154
/// </summary>
public abstract class Parus : Paridae, IParus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9154;

    /// <inheritdoc />
    public virtual string GenusName => "Parus";

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
