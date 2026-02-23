using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Dicrurus;

/// <summary>
/// Abstract class for Dicrurus (genus).
/// NCBI TaxId: 107204
/// </summary>
public abstract class Dicrurus : Dicruridae, IDicrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107204;

    /// <inheritdoc />
    public virtual string GenusName => "Dicrurus";

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
