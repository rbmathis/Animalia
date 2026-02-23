using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Glaucosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Glaucosomatidae.Glaucosoma;

/// <summary>
/// Abstract class for Glaucosoma (genus).
/// NCBI TaxId: 443780
/// </summary>
public abstract class Glaucosoma : Glaucosomatidae, IGlaucosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443780;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucosoma";

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
