using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Anous;

/// <summary>
/// Abstract class for Anous (genus).
/// NCBI TaxId: 297801
/// </summary>
public abstract class Anous : Laridae, IAnous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297801;

    /// <inheritdoc />
    public virtual string GenusName => "Anous";

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
