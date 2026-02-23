using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Elachuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Elachuridae.Elachura;

/// <summary>
/// Abstract class for Elachura (genus).
/// NCBI TaxId: 2821313
/// </summary>
public abstract class Elachura : Elachuridae, IElachura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elachura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821313;

    /// <inheritdoc />
    public virtual string GenusName => "Elachura";

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
