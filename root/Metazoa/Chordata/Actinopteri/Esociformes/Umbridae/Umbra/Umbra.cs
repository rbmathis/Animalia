using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Umbra;

/// <summary>
/// Abstract class for Umbra (genus).
/// NCBI TaxId: 75932
/// </summary>
public abstract class Umbra : Umbridae, IUmbra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Umbra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75932;

    /// <inheritdoc />
    public virtual string GenusName => "Umbra";

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
