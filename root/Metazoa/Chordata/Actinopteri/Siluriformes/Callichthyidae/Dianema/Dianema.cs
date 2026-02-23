using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Dianema;

/// <summary>
/// Abstract class for Dianema (genus).
/// NCBI TaxId: 245712
/// </summary>
public abstract class Dianema : Callichthyidae, IDianema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dianema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245712;

    /// <inheritdoc />
    public virtual string GenusName => "Dianema";

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
