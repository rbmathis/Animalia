using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Chloropipo;

/// <summary>
/// Abstract class for Chloropipo (genus).
/// NCBI TaxId: 170867
/// </summary>
public abstract class Chloropipo : Pipridae, IChloropipo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloropipo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170867;

    /// <inheritdoc />
    public virtual string GenusName => "Chloropipo";

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
