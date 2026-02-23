using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Sylviparus;

/// <summary>
/// Abstract class for Sylviparus (genus).
/// NCBI TaxId: 245589
/// </summary>
public abstract class Sylviparus : Paridae, ISylviparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylviparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245589;

    /// <inheritdoc />
    public virtual string GenusName => "Sylviparus";

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
