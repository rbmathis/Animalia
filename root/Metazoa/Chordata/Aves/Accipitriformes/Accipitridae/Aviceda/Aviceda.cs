using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aviceda;

/// <summary>
/// Abstract class for Aviceda (genus).
/// NCBI TaxId: 258818
/// </summary>
public abstract class Aviceda : Accipitridae, IAviceda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aviceda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258818;

    /// <inheritdoc />
    public virtual string GenusName => "Aviceda";

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
