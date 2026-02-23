using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Eucinostomus;

/// <summary>
/// Abstract class for Eucinostomus (genus).
/// NCBI TaxId: 320604
/// </summary>
public abstract class Eucinostomus : Gerreidae, IEucinostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eucinostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320604;

    /// <inheritdoc />
    public virtual string GenusName => "Eucinostomus";

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
