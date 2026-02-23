using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Acantholabrus;

/// <summary>
/// Abstract class for Acantholabrus (genus).
/// NCBI TaxId: 202582
/// </summary>
public abstract class Acantholabrus : Labridae, IAcantholabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantholabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202582;

    /// <inheritdoc />
    public virtual string GenusName => "Acantholabrus";

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
