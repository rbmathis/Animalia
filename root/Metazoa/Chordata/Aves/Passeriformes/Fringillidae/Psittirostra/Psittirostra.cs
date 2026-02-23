using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Psittirostra;

/// <summary>
/// Abstract class for Psittirostra (genus).
/// NCBI TaxId: 1804741
/// </summary>
public abstract class Psittirostra : Fringillidae, IPsittirostra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittirostra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1804741;

    /// <inheritdoc />
    public virtual string GenusName => "Psittirostra";

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
