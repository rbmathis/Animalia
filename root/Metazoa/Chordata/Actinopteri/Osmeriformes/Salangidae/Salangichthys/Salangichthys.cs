using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Salangichthys;

/// <summary>
/// Abstract class for Salangichthys (genus).
/// NCBI TaxId: 137521
/// </summary>
public abstract class Salangichthys : Salangidae, ISalangichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salangichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137521;

    /// <inheritdoc />
    public virtual string GenusName => "Salangichthys";

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
